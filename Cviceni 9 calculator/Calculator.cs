using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_09_calculator
{
    public class Calculator
    {

        public string Memory;
        private string firstNumber;
        private string secondNumber;
     //   private double KC;
        private string operand;
        private double result;
        private double numInMemory;
        private enum State
        {
            FirstNumber,
            Operation,
            SecondNumber,
    //        KC,
            Result
        };
        private State _state;
        public Calculator()
        {
            Memory = "";
            firstNumber = "";
            secondNumber = "";
    //        KC = 0.256;
            operand = "";
            result = 0;
            numInMemory = 0;
            _state = State.FirstNumber;
        }
        public string Display
        {
            get
            {
                switch (_state)
                {
                    case State.FirstNumber:
                        return firstNumber;
                    case State.Operation:
                        return firstNumber + operand;
                    case State.SecondNumber:
                        return firstNumber + operand + secondNumber;
                    case State.Result:
                        return result.ToString();
                    default:
                        return "";
                }
            }
        }
        public void Button(string buttonContent)
        {
            switch (buttonContent)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    processNumberPress(buttonContent);
                    break;
                case "MC":
                case "MR":
                case "MS":
                case "M+":
                case "M-":
                    processMemoryOperation(buttonContent);
                    break;
                case "<=":
                case "CE":
                case "C":
                    processClearOperation(buttonContent);
                    break;
                case "+/-":
                case "+":
                case "-":
                case "/":
                case "*":
                case " KC ":
                case ",":
                    processOperand(buttonContent);
                    break;
                case "=":
                    if (_state == State.SecondNumber) calculateResult();
                    break;
            }
        }
        private void processNumberPress(string number)
        {
            switch (_state)
            {
                case State.FirstNumber:
                    firstNumber += number;
                    break;
                case State.SecondNumber:
                    secondNumber += number;
                    break;
                case State.Operation:
                    secondNumber += number;
                    _state = State.SecondNumber;
                    break;
            }
        }
        private void processMemoryOperation(string operationButton)
        {
            switch (operationButton)
            {
                case "MC":
                    numInMemory = 0;
                    Memory = "";
                    break;
                case "MR":
                    if (Memory == "") break;
                    switch (_state)
                    {
                        case State.FirstNumber:
                            firstNumber = numInMemory.ToString();
                            break;
                        case State.Operation:
                            secondNumber = numInMemory.ToString();
                            _state = State.SecondNumber;
                            break;
                        case State.SecondNumber:
                            secondNumber = numInMemory.ToString();
                            break;
                    }
                    break;
                case "MS":
                    switch (_state)
                    {
                        case State.FirstNumber:
                            if (firstNumber != "") numInMemory = Double.Parse(firstNumber);
                            break;
                        case State.SecondNumber:
                            if (secondNumber != "") numInMemory = Double.Parse(secondNumber);
                            break;
                    }
                    Memory = "M";
                    break;
                case "M+":
                    if (Memory == "") break;
                    switch (_state)
                    {
                        case State.FirstNumber:
                            if (firstNumber != "") numInMemory += Double.Parse(firstNumber);
                            break;
                        case State.Operation:
                            break;
                        case State.SecondNumber:
                            if (secondNumber != "") numInMemory += Double.Parse(secondNumber);
                            break;
                    }
                    break;
                case "M-":
                    if (Memory == "") break;
                    switch (_state)
                    {
                        case State.FirstNumber:
                            if (firstNumber != "") numInMemory -= Double.Parse(firstNumber);
                            break;
                        case State.Operation:
                            break;
                        case State.SecondNumber:
                            if (secondNumber != "") numInMemory -= Double.Parse(secondNumber);
                            break;
                    }
                    break;

            }
        }
        private void processClearOperation(string clearButton)
        {
            switch (clearButton)
            {
                case "<=":
                    switch (_state)
                    {
                        case State.FirstNumber:
                            if (firstNumber.Length > 0) firstNumber = firstNumber.Substring(0, firstNumber.Length - 1);
                            if (firstNumber == "-") firstNumber = "";
                            break;
                        case State.Operation:
                            _state = State.FirstNumber;
                            break;
                        case State.SecondNumber:
                            if (secondNumber.Length > 0)
                            {
                                secondNumber = secondNumber.Substring(0, secondNumber.Length - 1);
                                if (secondNumber == "-") secondNumber = "";
                            }
                            else _state = State.FirstNumber;
                            break;
                    }
                    break;
                case "C":
                    clearDisplay();
                    break;
                case "CE":
                    switch (_state)
                    {
                        case State.FirstNumber:
                            firstNumber = "";
                            break;
                        case State.SecondNumber:
                            secondNumber = "";
                            break;
                        default:
                            break;
                    }
                    break;
            }
        }
        private void processOperand(string operandButton)
        {
            switch (operandButton)
            {
                case "+/-":
                    switch (_state)
                    {
                        case State.FirstNumber:
                            negateString(ref firstNumber);
                            break;
                        case State.Operation:
                            secondNumber = negateString(firstNumber);
                            _state = State.SecondNumber;
                            break;
                        case State.SecondNumber:
                            negateString(ref secondNumber);
                            break;
                    }
                    break;
                case "+":
                case "-":
                case " KC ":
                case "*":
                case "/":
                    switch (_state)
                    {
                        case State.FirstNumber:
                            if (firstNumber == "") firstNumber = "0";
                            break;
                        case State.SecondNumber:
                            calculateResult();
                            firstNumber = result.ToString();
                            break;
                        default:
                            break;
                    }
                    operand = operandButton;
                    _state = State.Operation;
                    break;
                case ",":
                    switch (_state)
                    {
                        case State.FirstNumber:
                            if (firstNumber == "") firstNumber = "0";
                            firstNumber += ",";
                            break;
                        case State.SecondNumber:
                            if (secondNumber == "") secondNumber = "0";
                            secondNumber += ",";
                            break;
                        case State.Operation:
                            secondNumber = "0,";
                            _state = State.SecondNumber;
                            break;
                    }
                    break;
            }
        }
        private void calculateResult()
        {
            if (firstNumber == "") firstNumber = "0";
            if (secondNumber == "") secondNumber = "0";
            switch (operand)
            {
                case "+":
                    result = Double.Parse(firstNumber) + Double.Parse(secondNumber);
                    break;
                case "-":
                    result = Double.Parse(firstNumber) - Double.Parse(secondNumber);
                    break;
                case "*":
                    result = Double.Parse(firstNumber) * Double.Parse(secondNumber);
                    break;
                case "/":
                    result = Double.Parse(firstNumber) / Double.Parse(secondNumber);
                    break;
                case " KC ":
                    result = Double.Parse(firstNumber) * 0.265;
                    break;
                default:
                    break;
            }
            firstNumber = "";
            secondNumber = "";
            _state = State.Result;
        }
        private void clearDisplay()
        {
            _state = State.FirstNumber;
            firstNumber = "";
            secondNumber = "";
        }
        private void negateString(ref string input)
        {
            if (input.Length == 0 || input == "0") return;
            if (input[0] == '-') input = input.Substring(1);
            else input = "-" + input;
        }
        private string negateString(string input)
        {
            if (input.Length == 0 || input == "0") return "";
            if (input[0] == '-') return input.Substring(1);
            else return "-" + input;
        }
    }
}

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculator();
        }
        public static void Calculator(){
            int fisrValue = GetValue("Enter Value 1: ");
            int secondValue = GetValue("Enter Value 2: ");
            Calculate(fisrValue,secondValue);
        }
        public static void Calculate(int v1, int v2){
            char selectOperation = SelectOperation();
            int result = 0;
            switch (selectOperation)
            {
                case '+':
                    result = v1 + v2; 
                    break;
                case '-':
                    result = v1 - v2; 
                    break;
                case '*':
                    result = v1 * v2; 
                    break;
                case '/':
                    result = v1 * v2; 
                    break;
                default:
                    WriteLine("choose from the supported operators");
                    break;
            }
            WriteLine($"Result: {result}");
        }
        public static int GetValue(string label){
            Write(label);
            int value = Convert.ToInt32(ReadLine());
            while (value == 0){
                Write(label);
                value = Convert.ToInt32(ReadLine());
                if(value != 0){
                    break;
                }
            }
            return value;
        }        
        public static char SelectOperation(){
            char[] Operations = {'+' , '*' , '-' , '/'};
            Write("Select an operation: ");
            char opr = (char)Read();
            while (!Operations.Contains(opr)){
                Write("Invalid , Please select an op: ");
                opr = (char)Read();
                if(Operations.Contains(opr))
                    break;                 
            }
            return opr;
        }
    }
}

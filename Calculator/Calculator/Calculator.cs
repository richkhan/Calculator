namespace MyCalculator
{
    public class Calculator
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private enum Operator {None, Add, Subtract, Multiply, Divide }
        private Operator op;

        private bool opPressed;
        private bool hasOperand2;

        public Calculator()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            opPressed = false;
            op = Operator.None;
        }

        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public void Add(decimal displayValue)
        {
            currentValue = displayValue;
            operand1 = displayValue;
            op = Operator.Add;
            opPressed = true;
        }

        public void Subtract(decimal displayValue)
        {
            currentValue = displayValue;
            operand1 = displayValue;
            op = Operator.Subtract;
            opPressed = true;
        }
        public void Divide(decimal displayValue)
        {
            currentValue = displayValue;
            operand1 = displayValue;
            op = Operator.Divide;
            opPressed = true;
        }

        public void Multiply(decimal displayValue)
        {
            currentValue = displayValue;
            operand1 = displayValue;
            op = Operator.Multiply;
            opPressed = true;
        }



        public void Equals(decimal displayValue)
        {
            operand2 = displayValue;
            Equals();
        }

        public void Equals()
        {
            switch (op)
            {
                case Operator.Add:
                    currentValue = operand1 + operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Subtract:
                    currentValue = operand1 - operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Multiply:
                    currentValue = operand1 * operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Divide:
                    currentValue = operand1 / operand2;
                    operand1 = currentValue;
                    break;
            }
        }

        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            opPressed = false;
            op = Operator.None;
        }

        public bool OpPressed()
        {
            return opPressed;
        }

        public void SetOpPressed(bool value)
        {
            opPressed = value;
        }

        public bool HasOperand2()
        {
            return hasOperand2;
        }

        public void SetHasOperand2(bool value)
        {
            hasOperand2 = value;
        }
    }
}

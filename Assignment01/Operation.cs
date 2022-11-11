using System;

namespace Assignment {

    public abstract class Operation : ImplicitGeometry {
        // Implicit object가 2개 형성(circle, rectangle은 circle, rectangle 클래스인데,)
        public ImplicitGeometry operand1, operand2;

        //abstract class can't create an object. 
        public Operation (ImplicitGeometry operand1, ImplicitGeometry operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }
    }
}
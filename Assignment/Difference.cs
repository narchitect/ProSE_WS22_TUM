using System;

namespace Assignment{
    public class Union : Operation
    {
        //추상 클래스의 자식 클래스는 추상부모클래스의 생성자를 이용해한다.
        public Union(ImplicitGeometry operand1, ImplicitGeometry operand2 ) : base(operand1, operand2) {}
        public override bool IsInside(double x, double y) {
            return operand1.IsInside(x,y) || operand2.IsInside(x,y);
        }
    
    }

}

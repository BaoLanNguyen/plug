class Rectangle : Shape{
    public override double Area(){
        return Width*Height;
    }
    public Rectangle(double Width, double Height) : base(Width, Height){}
}
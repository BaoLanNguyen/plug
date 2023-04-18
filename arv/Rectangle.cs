class Rectangle : Shape{
    public double Area(){
        return Width*Height;
    }
    public Rectangle(double Width, double Height) : base(Width, Height){}
}
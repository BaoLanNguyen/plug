class Triangle : Shape{
    public double Area(){
        return Width*Height/2;
    }
    public Triangle(double Width, double Height) : base(Width, Height){}
}
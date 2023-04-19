class Triangle : IShape{
    double Width;
    double Height;
    public double Area(){
        return Width*Height/2;
    }
    public Triangle(double Width, double Height){
        this.Width = Width;
        this.Height = Height;
    }
}
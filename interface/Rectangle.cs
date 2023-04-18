class Rectangle : IShape{
    double Width;
    double Height;
    public double Area(){
        return Width*Height;
    }
    public Rectangle(double Width, double Height){
        this.Width = Width;
        this.Height = Height;
    }
}
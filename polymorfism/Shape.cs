class Shape{
 private double width;
 private double height;
 public double Width{
    get {return width;}
    set {width = value;}
 }
  public double Height{
    get {return height;}
    set {height = value;}
 }
 public virtual double Area(){
   return 1;
 }
 public Shape(double width, double height){
    this.width = width;
    this.height = height;
 }
}
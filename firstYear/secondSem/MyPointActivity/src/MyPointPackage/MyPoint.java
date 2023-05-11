package MyPointPackage;

public class MyPoint {
    private int x, y;

    public MyPoint() {
        this.x = 0;
        this.y = 0;
    }

    public int getX() {
        return this.x;
    }

    public int getY() {
        return this.y;
    }

    public void setX(int x){
        this.x = x;
    }

    public void setY(int y){
        this.y = y;
    }

    public void setXY(int x, int y) {
        setX(x);
        setY(y);
    }

    public String printCoordinates(){
        String coord;
        return coord = "(" + Integer.toString(getX()) + ", " + Integer.toString(getY()) + ")";
    }

    public double distance(int x, int y){
        return Math.sqrt((Math.pow(x - this.x, 2) + (Math.pow(y - this.y, 2))));
    }


    public static void main(String[] args) {//DEBUG
        MyPoint point = new MyPoint();
        point.setXY(2,4);
        System.out.print(point.printCoordinates());
        System.out.println(point.distance(4, 2));


    }

}




package Rodriguez_Class;

public class Student {
    int studentNo;
    String fname, lname, course;

    public Student() {
        this.studentNo = 0;
        this.fname = null;
        this.lname = null;
        this.course = null;
    }

    public void setStudentNo(int studentNo){
        this.studentNo = studentNo;
    }

    public void setFname(String Fname){
        this.fname = Fname;
    }

    public void setLname(String Lname){
        this.lname = Lname;
    }

    public void setCourse(String Course){
        this.course = Course;
    }

    public int getStudentNo(){
        return this.studentNo;
    }

    public String getFname(){
        return this.fname;
    }

    public String getLname(){
        return this.lname;
    }

    public String getCourse(){
        return this.course;
    }

    public static void main(String[] args) {
        Student student = new Student();
        System.out.println("default");//default output
        System.out.println(student.getStudentNo());
        System.out.println(student.getFname());
        System.out.println(student.getLname());
        System.out.println(student.getCourse());
        System.out.print("\n");

        student.setStudentNo(01);
        student.setFname("matthew");
        student.setLname("rinaudo");
        student.setCourse("streamer");

        System.out.println("altered");//altered output
        System.out.println(student.getStudentNo());
        System.out.println(student.getFname());
        System.out.println(student.getLname());
        System.out.println(student.getCourse());
    }


}
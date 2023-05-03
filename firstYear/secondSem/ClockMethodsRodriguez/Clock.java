package ClockMethodsRodriguez;

public class Clock {
    private int hours;
    private int minutes;
    private int seconds;
    
    public int getHours(){
        return this.hours;
    }
    public int getMinutes(){
        return this.minutes;
    }
    public int getSeconds(){
        return this.seconds;
    }
    public void setTime(int hr, int min, int sec){
        if (hr>=0 && hr <24)
            this.hours = hr; //method accepts the value if it is valid
        else
            this.hours=0;//if value received is invalid, hours will be 0
        
        if (min>=0 && min <60)
            this.minutes = min; //method accepts the value if it is valid
        else
            this.minutes=0;//if value received is invalid, minutes will be 0
          if (sec>=0 && sec <60)
            this.seconds = sec; //method accepts the value if it is valid
        else
            this.seconds=0;//if value received is invalid, seconds will be 0
    } 
    public void printTime(){
        if (this.hours < 10)
            System.out.print("0");
        System.out.print(this.hours + ":");
        
         if (this.minutes < 10)
            System.out.print("0");
        System.out.print(this.minutes + ":");
            
         if (this.seconds < 10)
            System.out.print("0");
        System.out.println(this.seconds);
    }

    public void printTimeFormat(boolean format){
        String timeIndication = "AM";

        if (format == true){//true for 12hr
            if (this.hours < 10)
                System.out.print("0");
            System.out.print(this.hours + ":");

            if (this.hours > 12)
                this.hours = this.hours - 12;
            System.out.print(this.hours + ":");
            timeIndication = "PM";

            if (this.minutes < 10)
                System.out.print("0");
            System.out.print(this.minutes + ":");

            if (this.seconds < 10)
                System.out.print("0");
            System.out.println(this.seconds + timeIndication);

        }

        if (format == false){//false for 24hr
            printTime();
        }
    }
        
        public static void main(String[] args) {
            Clock myClock = new Clock();
            myClock.setTime(8, 30, 50);
            myClock.printTimeFormat(false);

        }

}

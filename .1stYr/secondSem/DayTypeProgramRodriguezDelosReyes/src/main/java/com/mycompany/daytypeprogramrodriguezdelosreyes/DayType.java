package com.mycompany.daytypeprogramrodriguezdelosreyes;


public class DayType {
    private String day;
    
    public DayType(){
        this.day = "Sun";
    }
    
    public String getDay(){
        return this.day;
    }
    
    public void setDay(String sday){
        this.day = sday.substring(0, 3);        
    }
    
    public String getNextDay(){
        String day[] = {"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};
        int index = java.util.Arrays.asList(day).indexOf(this.day);
        return day [(index + 1) %7];
        
    }
     public String getPrevDay(){
         String day[] = {"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};
         int index = java.util.Arrays.asList(day).indexOf(this.day);
         return day [(index +6) %7];
     }
     
     public String getDayAfterAdd(int n){
         String day[] = {"Mon", "Tue", "Wed", "Thu","Fri","Sat","Sun"};
         int index = java.util.Arrays.asList(day).indexOf(this.day);
         return day [(index +n) %7];
     }
     
     public String getDayAfterSub(int n){
         String day[] = {"Mon", "Tue", "Wed", "Thu","Fri","Sat","Sun"};
         int index = java.util.Arrays.asList(day).indexOf(this.day);
         return day [(index +7 - n) %7];
     }
    

    public static void main(String[] args) {
//        DayType daytype = new DayType();
//        System.out.println(daytype.getDay());
//        System.out.println(daytype.getNextDay(1));
//        System.out.println(daytype.getPrevDay(1));
    }
}

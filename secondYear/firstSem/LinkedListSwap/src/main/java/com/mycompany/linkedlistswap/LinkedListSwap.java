/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.linkedlistswap;

import java.util.*;

/**
 *
 * @author student
 */
public class LinkedListSwap {
    
    public static void Swap(LinkedList<Integer> list,int n, int m){
        int temp = list.get(n);
        list.set(n, list.get(m));
        list.set(m, temp);

        
    }
    

    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        list.add(4);
        list.add(2);
        list.add(3);
        list.add(5);
        System.out.println(list);
        Swap(list,3,1);
        System.out.println(list);
    }
}

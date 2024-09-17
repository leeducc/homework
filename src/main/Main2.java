package main;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedList;
public class Main2 {
    public static int[] removeElement(int[] arr, int index) {

        if (index < 0 || index >= arr.length) {
            throw new IndexOutOfBoundsException("Index out of bounds: " + index);
        }

        int[] newArr = new int[arr.length - 1];


        System.arraycopy(arr, 0, newArr, 0, index);

        System.arraycopy(arr, index + 1, newArr, index, arr.length - index - 1);

        return newArr;
    }


    public static void main(String[] args){
        System.out.println ("STATIC ARRAY");
        int[] staticArray = {0,1,2,3,4,5,6,7,8};
        System.out.println(Arrays.toString(staticArray));

        staticArray = removeElement(staticArray, 3);

        System.out.println(Arrays.toString(staticArray));
        System.out.println (staticArray[0]);

        System.out.println ("DYNAMIC ARRAY");
        ArrayList<Integer> dynamicArray = new ArrayList<Integer>();
        dynamicArray.add(0);
        dynamicArray.add(1);
        dynamicArray.add(2);
        dynamicArray.add(3);
        System.out.println(dynamicArray);
        dynamicArray.remove(0);
        System.out.println(dynamicArray);
        System.out.println (dynamicArray.get (1));

        System.out.println ("LINK LIST");
        LinkedList<Integer> linkedList = new LinkedList<Integer>();
        linkedList.add(0);
        linkedList.add(1);
        linkedList.add(2);
        linkedList.add(3);
        System.out.println(linkedList);
        linkedList.remove(0);
        System.out.println(linkedList);
        System.out.println (linkedList.get (1));
    }


}

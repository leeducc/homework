package main;

import java.util.Arrays;
import entity.TreeNode;

public class Main {
    public static void main (String[] args) {
        TreeNode root = new TreeNode("Home");
        TreeNode child1 = new TreeNode("About Us");
        TreeNode child2 = new TreeNode("Services");
        TreeNode child3 = new TreeNode("Contact ");
        root.addChild(child1);
        root.addChild(child2);
        root.addChild(child3);
        TreeNode leaf1 = new TreeNode("Web Development");
        TreeNode leaf2 = new TreeNode("Mobile Apps");
        child2.addChild(leaf1);
        child2.addChild(leaf2);
        root.printTree();
        System.out.println ("\n\n");


        TreeNode root2 = new TreeNode("Country");
        TreeNode child4 = new TreeNode("Provinces");
        TreeNode child5 = new TreeNode("States");
        root2.addChild(child4);
        root2.addChild(child5);
        TreeNode leaf3 = new TreeNode("Cities");
        TreeNode leaf4 = new TreeNode("Districts");
        child4.addChild(leaf3);
        child4.addChild(leaf4);
        root2.printTree();
        System.out.println ("\n\n");


        TreeNode root3 = new TreeNode("CEO");
        TreeNode child6 = new TreeNode("HR");
        TreeNode child7 = new TreeNode("Fiance");
        TreeNode child8 = new TreeNode("Marketing");
        root3.addChild(child6);
        root3.addChild(child7);
        root3.addChild(child8);
        TreeNode leaf5 = new TreeNode("Leader");
        TreeNode leaf6 = new TreeNode("Employees");
        child6.addChild(leaf5);
        child6.addChild(leaf6);
        child7.addChild(leaf5);
        child7.addChild(leaf6);
        child8.addChild(leaf5);
        child8.addChild(leaf6);
        root3.printTree();
        System.out.println ("\n\n");
    }
}


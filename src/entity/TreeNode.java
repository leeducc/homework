package entity;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class TreeNode {
    String data;
    List<TreeNode> children;
    public TreeNode (String data){
        this.data = data;
        children = new ArrayList<> ();
    }
    public void addChild(TreeNode child){
        children.add(child);
    }
    public void printTree(String prefix) {
        System.out.println(prefix + data);
        for (TreeNode child : children) {
            child.printTree(prefix + "--");
        }
    }
    public void printTree() {
        printTree("");
    }
}

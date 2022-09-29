namespace TreeAlgos;
public class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int val=0, BinaryTree left=null, BinaryTree right=null)
    {
        value=val;
        this.left=left;
        this.right=right;
    }

    public List<int> InorderTraversal()
    {
        BinaryTree root=this;
        List<int> result=new List<int>();
        return InorderTraversal(root,result);
    }
    public List<int> InorderTraversal(BinaryTree node,List<int> result)
    {
            if(node!=null)
            {
                InorderTraversal(node.left,result);
                result.Add(node.value);
                InorderTraversal(node.right,result);
            }

            return result;
    }

     public List<int> PreOrderTraversal()
    {
        BinaryTree root=this;
        List<int> result=new List<int>();
        return PreOrderTraversal(root,result);
    }
     public List<int> PreOrderTraversal(BinaryTree node,List<int> result)
    {
            if(node!=null)
            {
                result.Add(node.value);
                PreOrderTraversal(node.left,result);
                
                PreOrderTraversal(node.right,result);
            }

            return result;
    }
}

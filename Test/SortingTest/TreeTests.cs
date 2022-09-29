using TreeAlgos;
namespace SortingTest;

[TestClass]
public class TreeTests
{
    [TestMethod]
    public void TestInorderTraversal()
    {
        var n1= new BinaryTree(1);
        var n2= new BinaryTree(2);
        var n3= new BinaryTree(3);
        var n4= new BinaryTree(4);
        var n5= new BinaryTree(5);
        var n6= new BinaryTree(6);
        var n7= new BinaryTree(7);
        var n8= new BinaryTree(8);

        n1.left=n2;
        n1.right=n3;
        n2.left=n4;
        n2.right=n5;
        n3.left=n6;
        n3.right=n7;
       n4.left=n8;

       var inorderExpected = new int[]{8,4,2,5,1,6,3,7};
       var actual = n1.InorderTraversal();
       for(int i=0;i<inorderExpected.Length;i++)
       {
             Assert.AreEqual(actual[i],inorderExpected[i]);
       }     
    }

[TestMethod]
    public void TestPreorderTraversal()
    {
        var n1= new BinaryTree(1);
        var n2= new BinaryTree(2);
        var n3= new BinaryTree(3);
        var n4= new BinaryTree(4);
        var n5= new BinaryTree(5);
        var n6= new BinaryTree(6);
        var n7= new BinaryTree(7);
        var n8= new BinaryTree(8);

        n1.left=n2;
        n1.right=n3;
        n2.left=n4;
        n2.right=n5;
        n3.left=n6;
        n3.right=n7;
       n4.left=n8;

       var inorderExpected = new int[]{1,2,4,8,5,3,6,7};
       var actual = n1.PreOrderTraversal();
       for(int i=0;i<inorderExpected.Length;i++)
       {
             Assert.AreEqual(actual[i],inorderExpected[i]);
       }     
    }
}
 
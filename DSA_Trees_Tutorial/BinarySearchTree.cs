using System;
namespace DSA_Trees_Tutorial
{
	public class BinarySearchTree
	{
		public TreeNode Root { get; set; } = null;
		public void Insert(int key, string value)
		{
			Root = InsertItem(Root, key, value);
		}

		//Inserting in order traversal for the tree
		public void PrintInOrderTraversal()
		{
			InOrderTraversal(Root);

		}

		private void InOrderTraversal(TreeNode node)
		{
			if(node != null)
			{
				InOrderTraversal(node.LeftChild);
				Console.WriteLine(node.Key + " " + node.Value);
				InOrderTraversal(node.RightChild);
			}
		}


		//Pre order traversal

        public void PrintPreOrderTraversal()
        {
            PreOrderTraversal(Root);

        }

        private void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
				Console.WriteLine(node.Key + " " + node.Value);
                InOrderTraversal(node.LeftChild);
                InOrderTraversal(node.RightChild);
            }
        }




		//post order traversal
        public void PrintPostOrderTraversal()
        {
			PostOrderTraversal(Root);

        }

        private void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.LeftChild);
                PostOrderTraversal(node.RightChild);
                Console.WriteLine(node.Key + " " + node.Value);

            }
        }









        public TreeNode InsertItem(TreeNode node , int key, string value)
		{
			TreeNode newNode = new TreeNode(key, value);
			//IF this is the first time you insert, create the root
			if (node == null)
			{
				node = newNode;
				return node;
			}
			//if this isnt the first insert , traverse, find null, insert
			if(key < node.Key)
			{
				node.LeftChild = InsertItem(node.LeftChild, key, value);
			}
			else
			{
				node.RightChild = InsertItem(node.RightChild, key, value);
			}
			return node;
		}
		public string Find(int key)
		{
			TreeNode node = Find(Root, key);
			return node == null ? null : node.Value;
		}
		private TreeNode? Find(TreeNode node , int key)
		{
			if(node == null || node.Key == key)
			{
				return node;
			}
			else if(key < node.Key)
			{
				return Find(node.LeftChild, key);

			}
			else if(key > node.Key)
			{
				return Find(node.RightChild, key);
			}
			return null;
		}
	}
}


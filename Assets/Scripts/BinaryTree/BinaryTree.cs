public class BinaryTree<T>
{
	private BinaryTreeNode<T> root;
	
	public BinaryTree()
	{
		root = null;
	}
	
	public virtual void Clear()
	{
		root = null;
	}
	
	public BinaryTreeNode<T> Root
	{
		get
		{
			return root;
		}
		set
		{
			root = value;
		}
	}

	public bool Contains(T data)
	{
		BinaryTreeNode<T> current = root;
		if (current != null) {
			return current.Contain (data);
		}
		return false;
	}

	public BinaryTreeNode<T> Gets(T data)
	{
		BinaryTreeNode<T> current = root;
		if (current != null) {
			return current.Get (data);
		}
		return null;
	}

	public virtual void Add (T at, T data, int direction)
	{
		if (!Contains (at))
			return;

		BinaryTreeNode<T> parent = Gets (at);
		BinaryTreeNode<T> child = new BinaryTreeNode<T> (data);

		// left child
		if (direction == 0) {
			child.Left = parent.Left;
			parent.Left = child;
		} else {
			child.Right = parent.Right;
			parent.Right = child;
		}
	}

	public bool Remove(T data)
	{
		if (!Contains (data))
			return false;

		BinaryTreeNode<T> node = Gets (data);
		node = null;
		return true;
	}
}
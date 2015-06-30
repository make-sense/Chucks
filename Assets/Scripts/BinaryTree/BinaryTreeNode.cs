public class BinaryTreeNode<T> : Node<T>
{
	public BinaryTreeNode() : base() {}
	public BinaryTreeNode(T data) : base(data, null) {}
	public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
	{
		base.Value = data;
		NodeList<T> children = new NodeList<T>(2);
		children[0] = left;
		children[1] = right;
		
		base.Neighbors = children;
	}
	
	public BinaryTreeNode<T> Left
	{
		get
		{
			if (base.Neighbors == null)
				return null;
			else
				return (BinaryTreeNode<T>) base.Neighbors[0];
		}
		set
		{
			if (base.Neighbors == null)
				base.Neighbors = new NodeList<T>(2);
			
			base.Neighbors[0] = value;
		}
	}
	
	public BinaryTreeNode<T> Right
	{
		get
		{
			if (base.Neighbors == null)
				return null;
			else
				return (BinaryTreeNode<T>) base.Neighbors[1];
		}
		set
		{
			if (base.Neighbors == null)
				base.Neighbors = new NodeList<T>(2);
			
			base.Neighbors[1] = value;
		}
	}

	public bool Contain (T data)
	{
		if (base.Value.Equals (data)) {
			return true;
		} else {
			if (Left != null && Left.Contain (data))
				return true;
			if (Right != null && Right.Contain (data))
				return true;
		}
		return false;
	}

	public BinaryTreeNode<T> Get (T data) {
		if (base.Value.Equals (data)) {
			return this;
		} else {
			if (Left != null)
				if (Left.Get (data) != null)
					return Left.Get (data);
			if (Right != null)
				if (Right.Get (data) != null)
					return Right.Get (data);
		}
		return null;
	}
}
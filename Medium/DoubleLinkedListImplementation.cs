using System;
// Feel free to add new properties and methods to the class.
public class Program {
	public class DoublyLinkedList {
		public Node Head;
		public Node Tail;

		public void SetHead(Node node) {
			// Write your code here.
            if(this.Head == null){
                this.Head = node;
                this.Tail = node;
                return;
            }           
            // use InsertBefore method
            this.InsertBefore(this.Head, node);
		}

		public void SetTail(Node node) {
			// Write your code here.
            if(this.Head == null){
                SetHead(node);
                return;
            }
            // use InsertAfter method
            this.InsertAfter(this.Tail, node);
		}

		public void InsertBefore(Node node, Node nodeToInsert) {
			// Write your code here.
            if(nodeToInsert == this.Head && nodeToInsert == this.Tail){                
                return;
            }
            this.Remove(nodeToInsert);
            nodeToInsert.Prev = node.Prev;
            nodeToInsert.Next = node;
            
            if(node.Prev == null){
                this.Head = nodeToInsert;
            }            
            else{
                node.Prev.Next = nodeToInsert;
            }
            
            node.Prev = nodeToInsert;
		}

		public void InsertAfter(Node node, Node nodeToInsert) {
			// Write your code here.
            if(node == this.Head && nodeToInsert == this.Tail){                
                return;
            }

            this.Remove(nodeToInsert);
            
            nodeToInsert.Prev = node;
            nodeToInsert.Next = node.Next;
            
            if(node.Next == null){
                this.Tail = nodeToInsert;
            }
            else{
                node.Next.Prev = nodeToInsert;
            }

            node.Next = nodeToInsert;
		}

		public void InsertAtPosition(int position, Node nodeToInsert) {
			// Write your code here.
            if(position == 1){
                this.SetHead(nodeToInsert);
                return;
            }
            
            Node node = this.Head;
            int currentPosition = 1;
            while(node != null && currentPosition != position){
                node = node.Next;
                currentPosition++;
            }

            if(node != null){
                this.InsertBefore(node, nodeToInsert);
            }else{
              this.SetTail(nodeToInsert);  
            }           
            
		}

		public void RemoveNodesWithValue(int value) {
			// Write your code here.
            Node node = this.Head;
            while(node != null){
                Node nodeToRemove = node;
                node = node.Next;
                if(nodeToRemove.Value == value){
                    this.Remove(nodeToRemove);
                }
                
            }
            
		}

			// Write your code here.
		public void Remove(Node node){
            
            // node at the beginning of the list
            if(node == this.Head){
                this.Head = this.Head.Next;
            }

            if(node == this.Tail){
                this.Tail = this.Tail.Prev;
            }

            RemoveNodeBindings(node);
            
		}

        public void RemoveNodeBindings(Node node){
            if(node.Prev != null){
                node.Prev.Next = node.Next;
            }

            if(node.Next != null){
                node.Next.Prev = node.Prev;
            }

            node.Prev = null;
            node.Next = null;            
        }

		public bool ContainsNodeWithValue(int value) {
			// Write your code here.
            Node currentNode = new Node(value);
            currentNode = this.Head;

            while(currentNode != null && currentNode.Value != value){ 
                
                currentNode = currentNode.Next;
            }
			return (currentNode != null);
		}

        
	}

	// Do not edit the class below.
	public class Node {
		public int Value;
		public Node Prev;
		public Node Next;

		public Node(int value) {
			this.Value = value;
		}
	}
}

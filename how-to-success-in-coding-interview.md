## Basic Data Structures
## Array
* Pattern & Technique
  Whenever getting a problem that related to array, ask yourself the following questions:  
  1. Is the array sorted? If not, does sorting the array help to simplfy the problem?
  2. Can I use two and / or multiple pointers? The two pointers could be composed as a sliding window. Or, the two pointers could be put at the beginning and end of the array. Both sliding window and beginning-end pointers could help to reduce the time / space complexity.

## Linked-list
* Pattern & Technique
* Typical Interview Questions
1. Reverse a linked-list
2. Merge sorted linked-list
3. How to sort linked-list in Onlog(n) [time complexity]?
4. Find the middle of the list
5. Find cycle
6. Find cross

## Stack

## Queue

## Binary Tree
* Pattern & Technique
1. DFS / BFS
2. Rebuild binary tree from in-order / pre-order or pre-order / post-order
3. BST
4. How to generate a BST from a list?
* Typical Interview Questions:
1. LCA
2. Sum in a path
3. etc

## Heap

## Priority Queue

## Graph
* Pattern & Technique
1. DFS / BFS 
2. Topology sort
3. General Description:
	1. maze: find a path from start point to the destination.
	2. shortest path: find the shortest path between two known points.

Data Structure:
2D array like int[,] or int[][]

Algorithm:
	1. DFS:
	Normally, DFS can be usded to detect whether two points in the matrix is connected or not.
	Use recursion to implement the algorithm.
	The spread process of DFS is random, which means it's not possible to determine which one will be picked up in the next round.
	
	2. BFS:
	Normally, BFS is usded to detect the shortest path between start point and the destination. BFS can navigate from the start point layer by layer.
	Use queue to implement the algorithm.
	
	3. Common:
Both DFS and BFS needs an additional array (boolean[,] or boolean[][]) to store whether current point is visited or not. It could prevent the the algorithm gets stuck in cycle.

Path related issue: Use a dictionary or hashtable to store the detected / known path.

## Advanced Data Structure
## Disjoint Set
* Pattern & Technique

## Segment Tree
* Pattern & Technique

## Indexed Binary Search Tree
* Pattern & Technique

## Basic Algorithm Techniques
## Sorting

## Searching

## Recursion

## Divide and Conquer

## Backtrack

## Sliding Window
two pointers

## Bitwise

## Greedy

## Dynamic Programming
* Pattern & Technique
* Typical Interview Questions

## Advanced Algorithm Techniques
## KMP

## Special Topics
* Sum
  When the problem is related to 'SUM', the sum 'prefix' will be a basic strategy to resolve the problem.
  Leetcode question: https://leetcode.com/problems/continuous-subarray-sum/description/
* Random Value
Leetcode question: https://leetcode.com/problems/implement-rand10-using-rand7/
* How to find a target group and the position in the group?
1. Use / to find which group the taget will drop into.
2. Use % to find the position in the group.
3. Single element in array.
4. Marjority in array.
5. Permutation: DFS, Leetcode 60

## String prefix problem
1. Use Trie to solve the string prefix problems.
2. Trie also can be used to compose a dictionary.

## Edge Testing Cases
* Test whether the inputs parameters are pointed to the same instance?
* The edge cases for Maths problem
1. Overflow: -2147483648 ~ 2147483648, Math.Abs(-2147483648), etc...

## Practice
* The list of must-do alogrithm problems:
https://www.geeksforgeeks.org/must-do-coding-questions-for-companies-like-amazon-microsoft-adobe/

* Problem Catalogs
1. Calendar overlap problems:
https://leetcode.com/problems/my-calendar-i/description/
https://leetcode.com/problems/my-calendar-ii/description/

Use De Morgan's laws to simplfy the conditions. Or, use TreeMap / SortedDictionary to store the data.

* Factor
Use (int i = 1; i * i < num; i++) as the condition of factor related problems.

* Use '#' to compose a completed tree. So that the tree will become unique.
https://leetcode.com/problems/find-duplicate-subtrees/description/

* Use AnnotationNode for trees.
https://leetcode.com/problems/cousins-in-binary-tree/description/

* For tree / graph problems:
The first step is to analyze how to traverse the data structure. DFS (For tree, pre-order / in-order / post-order?) OR BFS.

* Problems to detect unique: use hash table or directionary.

* The general code for Permutation and Combination

* The difference between lower case and upper case. (For instance, 'a' & 'A')

* bit problems
https://leetcode.com/problems/hamming-distance/description/

* Use stack to store the MAX value in a range

* Consider to refresh the index after the list structure is changed.

* List<T> can't delete elements according to the reference. Normally, it is necessary to build up a customized type to handle such scenario.

* Track the count of 26 characters.
int[] count = new int[26];
++count[c - 'a']; // if c is 'a', increase count[0].

* Use two arrays to determine four directions while travese a graph.
int[] rowChange = new int[] { -1, 1, 0, 0};
int[] colChange = new int[] { 0, 0, -1, 1};
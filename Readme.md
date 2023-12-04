# Programming Buddies Challenges - C# Solutions

## Challenge 1: Minimum Days for Kelly to Surpass Sam

### Problem Description

Sam and Kelly are programming buddies with different daily problem-solving capacities. Given Sam's daily problem-solving count, Kelly's daily count, and the initial difference in problems Sam has solved, the task is to find the minimum number of days for Kelly to surpass Sam. If Kelly cannot surpass Sam, the function returns -1.

### Function Description

```
int MinNum(int samDaily, int kellyDaily, int difference)
```



### Input

- `samDaily`: Number of problems Sam solves in a day (1 ≤ samDaily ≤ 100)
- `kellyDaily`: Number of problems Kelly solves in a day (1 ≤ kellyDaily ≤ 100)
- `difference`: Number of problems Sam is ahead initially (0 ≤ difference ≤ 100)



### Output

- Returns an integer: the minimum number of days needed by Kelly to exceed Sam, or -1 if it is impossible.



### Example

```
int result = MinNum(3, 5, 5);
// Output: 3
```


## Challenge 2: Longest Subsequence with Even Sum of Differences

### Problem Description

Consider every subsequence of an array of integers:

- Sort the subsequence in increasing order.
- Determine the sum of differences of elements in the subsequence.

Return the length of the longest subsequence where this sum is even.

### Function Description

```
int FindLongestSubsequence(int[] arr)
```



### Input

- `arr`: An array of integers (3 ≤ n ≤ 105, 0 ≤ arr[i] ≤ 109)



### Output

- Returns an integer: the length of the longest subsequence as described.



### Example

```
int[] inputArr = {1, 4, 2, 3};
int result = FindLongestSubsequence(inputArr);
// Output: 4
```

Feel free to use these C# solutions in your programming journey with Sam and Kelly's challenges. The provided functions are ready to be integrated into your projects.
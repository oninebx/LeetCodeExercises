# Restore IP Addresses

A valid IP address consists of exactly four integers separated by single dots. Each integer is between 0 and 255 (inclusive) and cannot have leading zeros.

For example, "0.1.2.201" and "192.168.1.1" are valid IP addresses, but "0.011.255.245", "192.168.1.312" and "192.168@1.1" are invalid IP addresses.
Given a string s containing only digits, return all possible valid IP addresses that can be formed by inserting dots into s. You are not allowed to reorder or remove any digits in s. You may return the valid IP addresses in any order.

 

## Example 1:

Input: s = "25525511135"
Output: ["255.255.11.135","255.255.111.35"]
Example 2:

Input: s = "0000"
Output: ["0.0.0.0"]
Example 3:

Input: s = "101023"
Output: ["1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"]
 

## Constraints:

* 1 <= s.length <= 20
* s consists of digits only.

## Analysis
The result is a set of permutations that meet the criteria, achievable through ***backtracking algorithm***.

Steps:

1. Create a method for recursion, whose parameters should include Data, Extend-index, Partial Candidates, ResultSet
2. The IP address has three dots, so the dots should be taken as the extend index that is between 1 and 3.
3. Reject conditions:
	* Each integer separated by single dot is not between 0 and 255.
	* The integer that is not 0 start with 0.
	* After generating the IP address, there are still remaining digits.
4. Extensions of Candidates:Each integer can consist of 1, 2 or 3 digits.So for each extend index, there should be 3 extensions at most.
5. The terminating scenario of the base case is extend-index equaling 4 
 

# Divide Two Integers

Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.

The integer division should truncate toward zero, which means losing its fractional part. For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.

Return the quotient after dividing dividend by divisor.

Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−2^31, 2^31 − 1]. For this problem, if the quotient is strictly greater than 2^31 - 1, then return 2^31 - 1, and if the quotient is strictly less than -2^31, then return -2^31.

 
## Examples
Example 1:

Input: dividend = 10, divisor = 3
Output: 3
Explanation: 10/3 = 3.33333.. which is truncated to 3.
Example 2:

Input: dividend = 7, divisor = -3
Output: -2
Explanation: 7/-3 = -2.33333.. which is truncated to -2.
 

## Constraints

-231 <= dividend, divisor <= 231 - 1
divisor != 0

## Analysis

Any integer can be represented by the following ploynomial. So `dividend = a0 * 2^0 + a1 * 2^1 + ... + ai * 2^i + ... + an * 2^n;` Assumping a0 = a1 = ... = ai = ... = an, the above formula can be simplified to `dividend = divisor * (2^0 + 2^1 + ... + 2^i + ... + 2^n) + remain`. ***i is a non-consecutive integer***. According to the problem description, the remainder will be omitted by truncating the quotient toward 0.

Quotient = 2^0 + 2^1 + ... + 2^i + ... + 2^n, 0 <= i <= n, i is non-consecutive and can be identified by shift operation.

### Edge cases
1. The diviend and divisor have opposite signs. **Converting them to positive integers, then setting the sign of the quotient**
2. Computing with long variables to avoid integer truncation(the quotient equals to -2^31 or 2^31 - 1)





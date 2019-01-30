# CodingChallenges

Random coding challenges and my attempt at solving them

### 1. Next Biggest Number

#### Rules

1. Given a number, find the next possible biggest number by reusing the number's digits.

| Input         | Output        |
| ------------- |:-------------:|
| 12            | 21            |
| 122           | 212           |
| 1234          | 1243          |
| 2017          | 2071          |
| 2071          | 2107          |
| 1234          | 1243          |
| 63842         | 64238         |
| 218765        | 251678        |
| 534976        | 536479        |

2. When a number does not have any next possible number, it returns -1 (e.g. 441 returns -1)

3. Invalid input strings throw an ArgumentException

<details><summary>Solution #1</summary>
<p>

#### Insert, Shift, Sort

1. Start at the lowest value (lowDigit)
    * 53497**6**
2. Iterate through the upper digits (highDigit)
3. If lowDigit > highDigit, insert lowDigit at highDigit index 
    * 53**4**976 becomes 53**6**497
4. Take the lowermost part before the swap and sort them in ascending order
    * 536**479**

![Solution 1](./Solutions/NextBiggestNumber1.gif "Solution 1")
</p>
</details>

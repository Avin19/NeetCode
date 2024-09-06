# Two Integer sum 

## Question - Easy


Given an arrat of integer nums and an integer target, retrun the indices i and j sunch taht nums[i] + nums[j] == target and i != j . 

You may assume that every inpit has exactly one pari of indices i and j that stidfy the condition .

Retrun the anser with the smaller inder first.


### Example 1 : 

```console

Input : 

nums = [ 3,4,5] , target = 7 

Output: 

Output: [0,1]

```
Explanation: nums[0] + nums[1] ==7 , so we retrun [0,1]. 

### Example 2 :

```console

Input: nums = [4,5,6] , target = 10 

Output : [0,2]

```

### Example 3 :

``` console 

Input: nums= [5,5], target =10 

Output: [0,1]

```

## Constraints

1. 2 <= nums. Length <= 1000
2. -10,000,00 < = nums[i] <= 10,000,000
3. -10,000,00 < = target <= 10,000,000
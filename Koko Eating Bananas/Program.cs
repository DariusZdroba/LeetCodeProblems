//Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas.The guards have gone and will come back in h hours.

//Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of bananas and eats k bananas from that pile. If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.

//Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.

//Return the minimum integer k such that she can eat all the bananas within h hours.



//Example 1:

//Input: piles = [3, 6, 7, 11], h = 8
//Output: 4
//Example 2:

//Input: piles = [30, 11, 23, 4, 20], h = 5
//Output: 30
//Example 3:

//Input: piles = [30, 11, 23, 4, 20], h = 6
//Output: 23

int MinEatingSpeed(int[] piles, int h)
{
    int max = piles.Max();
    int div = 1;
    long sum = h+1;
    //TODO 

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //Try binary search solution, instead of setting div from 1 trough max of piles, go for a 
    //divide and conquer solution, going to max/2, if larger, difference of max and max/2  / 2  and so on.
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    while (div <= max && sum > h)
    {
        sum = 0;
        for(int i=0; (i< piles.Length) && sum<=h ; i++) 
        {
            if (piles[i] % div == 0)
            {
                sum += piles[i] / div;
            }
            else
            {
                sum += (piles[i] / div) + 1;
            }
        }
        div++;
    }
    return div - 1;

}
int[] piles = { 332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184 };
MinEatingSpeed(piles, 823855818);
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

long Sum(int[] piles, int div,int h,long sum)
{
    sum = 0;
    for (int i = 0; (i < piles.Length) && sum <= h; i++)
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
    return sum;
}
int MinEatingSpeed(int[] piles, int h)
{
    int max = piles.Max();
    int div = max / 2;
    long sum = h+1;

    while (div <= max-1)
    {
        sum = Sum(piles, div, h, sum);
        if(sum <= h)
        {
            max = div;
            div = div / 2;
            if (div == 0) div = 1;
            
        }    
        else 
        {
            div = max - (max - div) / 2;
        }
       
        
    }
    return div - 1;

}
int[] piles = { 312884470 };
MinEatingSpeed(piles, 968709470);
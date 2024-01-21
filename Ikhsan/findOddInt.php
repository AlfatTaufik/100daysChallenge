<?php 

function findIt(array $seq) : int
{
    $count = array_count_values($seq);
  
    $result = array_filter($count, function($n) { return $n % 2 == 1; });
    $finalResult = array_keys($result);
  
    return $finalResult[0];
}

var_dump(findIt([20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5])); // 5

var_dump(findIt([1,1,2,-2,5,2,4,4,-1,-2,5])); // -1

/**
 * Mencari nilai array yang muncul dengan jumlah yang ganjil 
 * 
 */

?>
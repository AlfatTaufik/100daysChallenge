<?php

function isSame($a1, $a2) {
    if(is_null($a1) || is_null($a2)) {
        return false;
    }
    
    $arr = array_map(function($n){return $n*$n;}, $a1);
    
    sort($arr);
    sort($a2);
    
    return $arr == $a2;
}

$a1 = [121, 144, 19, 161, 19, 144, 19, 11];
$a2 = [11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19];
var_dump(isSame($a1,$a2)); // true

$b1 = [121, 144, 19, 161, 19, 144, 19, 11];
$b2 = [11*21, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19];
var_dump(isSame($b1,$b2)); // false

/**
 * Cek "apakah kedua array memiliki nilai yang sama?"
 * 
 */
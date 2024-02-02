<?php 

function digPow($n, $p) {
    $digits = str_split($n);
    $sum = 0;

    foreach ($digits as $digit) {
        $sum += pow($digit, $p);
        $p++;
    }

    if ($sum % $n == 0) {
        return $sum / $n;
    } else {
        return -1;
    }
}

echo digPow(89,1) . PHP_EOL; // 1
echo digPow(92,2) . PHP_EOL; // -1
echo digPow(100,2) . PHP_EOL; // -1
echo digPow(695,2) . PHP_EOL; // 51
echo digPow(46288,3) . PHP_EOL; // 51
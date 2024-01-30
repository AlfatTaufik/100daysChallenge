<?php
function past($h, $m, $s) {
    return $h * 3600000 + $m * 60000 + $s * 1000;
}

var_dump(past(1,1,1)); // 3661000
var_dump(past(0,1,1)); // 61000
var_dump(past(0,0,1)); // 1000
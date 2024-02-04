<?php

function josephus(array $items, int $k): array {
    $result = [];
    $count = count($items);
    $index = 0;

    while ($count > 0) {
        $index = ($index + $k - 1) % $count;
        $result[] = array_splice($items, $index, 1)[0];
        $count--;
    }

    return $result;
}

print_r(josephus([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 1));
// output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

print_r(josephus([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 2));
// output: [2, 4, 6, 8, 10, 3, 7, 1, 9, 5]

/*

Contoh=[1,2,3,4,5,6,7] dan k=3,
nilai k menunjukkan langkah atau jumlah elemen yang dihitung sebelum satu elemen dihapus
proses...

[1,2,3,4,5,6,7] - Urutan Awal
[1,2,4,5,6,7] => 3 dihitung dan masuk ke hasilnya [3]
[1,2,4,5,7] => 6 dihitung dan masuk ke hasilnya [3,6]
[1,4,5,7] => 2 dihitung dan masuk ke hasilnya [3,6,2]
[1,4,5] => 7 dihitung dan masuk ke hasilnya [3,6,2,7]
[1,4] => 5 dihitung dan masuk ke hasilnya [3,6,2,7,5]
[4] => 1 dihitung dan masuk ke hasilnya [3,6,2,7,5,1]
[] => 4 dihitung dan masuk ke hasilnya [3,6,2,7,5,1,4]

karena k=3 maka setiap 3 element (dihitung dari element setelah element sebelumnya dihapus) element ke-3 akan dihapus

*/

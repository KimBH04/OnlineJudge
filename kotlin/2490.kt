fun Yut(r:Int): Char {
    when (r) {
        0 -> return 'D'
        1 -> return 'C'
        2 -> return 'B'
        3 -> return 'A'
        4 -> return 'E'
        else -> return ' '
    }
}

fun main() {
    var i = 0
    while (i < 3){
        var yut = readLine()!!.split(' ')
        var r = 0
        for (j in yut) {
            r += j.toInt()
        }
        
        println(Yut(r))
        i++
    }
}
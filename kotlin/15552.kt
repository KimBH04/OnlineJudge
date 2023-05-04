import java.io.BufferedReader
import java.io.BufferedWriter
import java.io.InputStreamReader
import java.io.OutputStreamWriter
import java.util.StringTokenizer

fun main() {
    val reader = BufferedReader(InputStreamReader(System.`in`))
    var writer = BufferedWriter(OutputStreamWriter(System.out))

    repeat(reader.readLine().toInt()) {
        var input = StringTokenizer(reader.readLine())
        var a = input.nextToken().toInt()
        var b = input.nextToken().toInt()

        writer.write((a + b).toString())
        writer.write("\n")
    }

    writer.flush()
    writer.close()
}
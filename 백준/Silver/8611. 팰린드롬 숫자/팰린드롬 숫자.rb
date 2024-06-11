def to_base(n, base)
  result = []
  while n > 0
    result << n % base
    n /= base
  end
  return result.reverse.join
end

def is_palindrom(s)
  len = s.length / 2
  for i in 1..len
    if s[i - 1] != s[-i]
      return false
    end
  end
  return true
end

n = gets.chomp.to_i
results = []
tuple = Struct.new(:base, :n)
for i in 2..10
  s = to_base(n, i)
  if is_palindrom(s)
    results << tuple.new(i, s)
  end
end
if results.length == 0
  puts "NIE"
else
  for t in results
    printf "%s %d\n", t.base, t.n
  end
end

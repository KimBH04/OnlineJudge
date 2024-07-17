import sys
sys.setrecursionlimit(10001)

tree = {}
def make_tree(parent, child):
    if not parent in tree:
        tree[parent] = [-1, -1]

    right = parent < child  # False = left, True = right
    node = tree[parent]
    if node[right] == -1:
        node[right] = child
    else:
        make_tree(node[right], child)

def post(n):
    if n in tree:
        node = tree[n]
        if node[0] != -1:
            post(tree[n][0])
        if node[1] != -1:
            post(tree[n][1])
    sys.stdout.write(f'{n}\n')

pre_res = []
while 1:
    try:
        pre_res.append(int(sys.stdin.readline()))
    except:
        break

root = pre_res[0]
for n in pre_res[1:]:
    make_tree(root, n)

post(root)
while 1:
    try:
        s = input()
    except:
        break

    stack = []
    is_emoji = False
    is_cat = False
    for c in s:
        if c == ':':
            is_emoji = not is_emoji
            if is_emoji:
                stack.clear()
            elif len(stack) == 3 and ''.join(stack) == 'cat':
                is_cat = True
                break
            continue
            
        if is_emoji:
            stack.append(c)
    
    print("YES" if is_cat else "NO")
while 1:
    match input():
        case "animal":
            print("Panthera tigris")
        case "tree":
            print("Pinus densiflora")
        case "flower":
            print("Forsythia koreana")
        case "end":
            break
        case _:
            raise Exception("what")
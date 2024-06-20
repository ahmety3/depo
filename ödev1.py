def flatten(nested_list):
    flat_list = []
    for item in nested_list:
        if isinstance(item, list):
            flat_list.extend(flatten(item))
        else:
            flat_list.append(item)
    return flat_list

# Test the function
m = [[1,'a',['cat'],2],[[[3]],'dog'],4,5]
flatten_m = flatten(m)
print(flatten_m)
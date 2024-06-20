def reverse_nested_list(nested_list):
    reversed_list = []
    for item in reversed(nested_list):
        if isinstance(item, list):
            reversed_list.append(reverse_nested_list(item))
        else:
            reversed_list.append(item)
    return reversed_list

# Test the function
m = [[1, 2], [3, 4], [5, 6, 7]]
reversed_m = reverse_nested_list(m)
print(reversed_m)

def shipping_estimate():
    print("Greetings from FastTrack Shipping! Kindly follow the steps below.")
    
    # Get the weight of the package
    package_weight = float(input("Enter the weight of your package (lbs): "))
    
    # Check if the weight exceeds the limit
    if package_weight > 50:
        print("Sorry, your package exceeds the weight limit for FastTrack Shipping. Have a great day!")
        return
    
    # Get package dimensions
    package_width = float(input("Enter the width of your package (inches): "))
    package_height = float(input("Enter the height of your package (inches): "))
    package_length = float(input("Enter the length of your package (inches): "))
    
    # Verify if the total dimensions exceed the allowed size
    if (package_width + package_height + package_length) > 50:
        print("Unfortunately, your package is too large for FastTrack Shipping.")
        return
    
    # Calculate the shipping cost
    shipping_cost = (package_width * package_height * package_length * package_weight) / 100
    
    # Display the estimated shipping cost
    print(f"The estimated shipping cost for your package is: ${shipping_cost:.2f}")
    print("We appreciate your business!")

# Execute the function
shipping_estimate()
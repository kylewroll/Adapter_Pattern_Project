Author: Kyle Rolland
Date: 2/9/2021
File: READMME.md
Description: Short overview of project, design decisions, troubles, etc

  This project is a simple testing of what can be done with an adapter class. In this case, we have a Bear interface, and a Toy_bear interface. Bear has a child class called 
Grizzly, which has access to the maul() and hibernate() functions, while Toy_Bear has a child class called Teddy_Bear, which access to the hug() function. There is also a child 
class in the Toy_Bear file named Bear_Adapter, which is the adapter class for this project.
  Bear_Adapter has a Bear member variable, and contains a parameterized constructor that takes a bear as an argument, and sets the member variable to that bear. It also contains
a separate implementation of hug(), which takes that Bear variable and uses it to call maul(), adapting our Toy_Bear instance into a Bear instance.
  Everything in the program is hard coded, so all the user needs to do is run it, and the program will print out what is being printed, followed by the functions, and then move
onto the next test, meaning there is no extra user input to cause any hiccups (granted, the argument for the paramterized constructor is called 'User_Bear' even though the user
cannot actually interact with the code and input a Bear, but I just needed a name for the argument and that was the one that came to mind. It's only used once, anyways.)
  Included with the files is a Dia diagram of the program, which I based off of the previous Factory/Abstract Factory assignment, and the diagram from the lecture page on Adapters,
so it should be mostly accurate, but I'm still trying to get a feel for Dia for the time being, so there may be some mistakes here and there.
  All in all, this was a very quick and easy project, mostly because we are doing such a simple adaptation, and have complete control over the interfaces, with no user input.
I had a little bit of trouble when I first started implementing the adapter class, but when I looked back at the assignment instructions, I realized that I was just over thinking
what I had to do, which was a relief. However, I'm sure that if there were more outside factors and less control this would have taken much longer to make and much more time to 
figure out. Thankfully, that wasn't the case, and this was a quick and simple introduction to implementing adapter classes.

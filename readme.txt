Se implemento el patron de diseño Command Pattern ya que 
de esta forma se mantiene la separacion de tareas que puede
generar cada cliente y se pueden desarrollar distintos clientes para su ejecucion.
En este caso se cambio la cale Invoke ( del patron de diseno) por una clase abstracta
y de esta forma poder crear diferentes invokers con difernetes propiedades
abstrayendo solo unas acciones default para todo nuevo invoker.


Nota: Me di cuenta que la logica esta mal por que el tener muchos invokers 
te lleva a nada , yo queria mantener un robot que puediera ejecutar cada accion que le 
perteneceria a su dominio y de esta manera tener BackUpList como la lista de todas las tareas y despues preguntar a cada ARobot
de su peso disponible (falto este metodo) , al ultimo entendi que usar Factory para asignar a un robot nuevo la tarea y preguntar su
espacio de peso y asi realizar. Como iba a guardar las cosas en un txt en forma de lista para despues parsearla aun tipo de commando concreto
en el constructor esta el metodo de llamar el si hubo un error antes de que el robot empezara a preguntar por mas tarea. 
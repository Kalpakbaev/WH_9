
        //  Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в
        //   двоичную. 
       
      void decnumbers(int n){
        if(n > 0){
          if(n%2 == 1) decnumbers(n/2);
        }
            Console.Write(n +"");
      }
     
      Console.Write("Enter your naumber: ");
      int n = Convert.ToInt32(Console.ReadLine());
     
 
        
//Создать иерархию классов и интерфейсов для предметной области
//(класса 3 – 4, из них хотя бы один класс должен являться наследником другого класса),
//заданной номером варианта, и продемонстрировать её работу
//
//Столовая

  type IEmployer =
    abstract member TypeOf: string


  type Employer =
    val first_name : string
    val second_name : string

    new(first_name, second_name) =
      {
        first_name = first_name;
        second_name = second_name
      }

    member this.GetName =
      this.first_name + " " + this.second_name

    interface IEmployer with
      member this.TypeOf = "Employer"


  type Cook =
    inherit Employer

    val salary : int

    new(first_name, second_name, salary) =
      {
        inherit Employer(first_name, second_name)
        salary = salary
      }

    member this.GetSalary = this.salary
    interface IEmployer with
      member this.TypeOf = "Cook"


  type Manager =
    inherit Employer

    val salary : int

    new(first_name, second_name, salary) =
      {
        inherit Employer(first_name, second_name)
        salary = salary
      }

    member this.GetSalary = this.salary
    interface IEmployer with
      member this.TypeOf = "Manager"


  type Seller =
    inherit Employer

    val salary : int

    new(first_name, second_name, salary) =
      {
        inherit Employer(first_name, second_name)
        salary = salary
      }

    member this.GetSalary = this.salary
    interface IEmployer with
      member this.TypeOf = "Seller"

  [<EntryPoint>]
  let main argv =
    let print (ob : IEmployer) =
      printfn "Type of object - %s" <| ob.TypeOf

    let employer = new Employer("Иванов", "Иван")
    let cook = new Cook("Поваров", "Степан", 1000)
    let seller = new Seller("Продавцов", "Игорь", 2000)
    let manager = new Manager("Менеджеров", "Вася", 2500)

    let workers : List<IEmployer> = [employer; cook; seller; manager]

    workers
      |> List.iter print

    0;;

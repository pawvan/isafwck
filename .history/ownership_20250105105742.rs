fn process_file(file_path:&str){
    let content  = std::fs::read_to_string(file_path).unwrap()
    println!("{}",content)
}
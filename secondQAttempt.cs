// sudoku attempt through c# -- 0/300 
// iterating through rows and columns ??
// was on codesignal practice exam attempt #3

bool solution(int[][] grid) {
    
    int[] numbers = new int[9];
    for(int x = 1; x < 9; x += 3) {
        for(int y = 1; y < 9; y += 3) {
            for(int z = -1; z < 2; z++) {
                for(int w = -1; w < 2; w++) {
                    numbers[grid[x + z][y + w] - 1]++;
                }
            }
            if(!numbers.All(i => i == 1)) 
                return false;
                numbers = new int[9];
        }
    }
    
    int[] sudoku = new int[9];
    for(int x = 0; x < 9; x++) {
        for(int y = 0; y < 9; y++) {
            numbers[grid[x][y] - 1]++;
            sudoku[grid[y][x] - 1]++;
        }
        if(!numbers.All(i => i == 1) || !sudoku.All(i => i == 1)) 
            return false;
            numbers = new int[9];
            sudoku = new int[9];
    }
    
    return true;
}
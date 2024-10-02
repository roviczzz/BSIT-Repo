package com.example.lottoapplication;

import java.util.HashSet;
import java.util.Random;

public class LottoUtils {
    public static HashSet<Integer> generateWinningNumbers(int count, int max) {
        HashSet<Integer> winningNumbers = new HashSet<>();
        Random random = new Random();

        while (winningNumbers.size() < count) {
            winningNumbers.add(random.nextInt(max) + 1);
        }

        return winningNumbers;
    }

    public static String calculatePrize(int matches) {
        switch (matches) {
            case 0:
            case 1:
            case 2:
            case 3:
                return "Better luck next time";
            case 4:
                return "Congratulations! You've won $20,000.00";
            case 5:
                return "Congratulations! You've won $50,000.00";
            case 6:
                return "JACKPOT! YOU'VE WON $1,000,000.00";
            default:
                return "Invalid number of matches";
        }
    }
}

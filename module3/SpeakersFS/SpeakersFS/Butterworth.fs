module SpeakersFS.Butterworth

let firstOrderCapacitance crossoverFrequency impedance =
    (0.159 / (crossoverFrequency * impedance)) * 1000000.0

let firstOrderInductance crossoverFrequency impedance =
    (impedance / (6.28 * crossoverFrequency)) * 1000.0

let secondOrderCapacitance crossoverFrequency impedance =
    (0.1125 / (crossoverFrequency * impedance)) * 1000000.0

let secondOrderInductance crossoverFrequency impedance =
    ((impedance * 0.2251) / crossoverFrequency) * 1000.0
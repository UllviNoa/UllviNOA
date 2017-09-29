import math
import random

ff_start = 1.02
insattning = 2000.0000

for m in range(60) :
    insattning = insattning * ff_start ** (1.0/12.0)
    darand = 0.005 *(2 * random.random() - 1)

    #if random.randint(1,3) == 1 :
     #   ff_start -= 0.005


print insattning

class bubbleSort {
    sort(intArray) {
        if (typeof (intArray) === 'Array') {
            const size = intArray.size;
            let unSorted = size;
            for (let i = 0; i < size; i++) {
                for(let j=1;j<unSorted;j++){
                    if(intArray[j-1]>intArray[j]){
                        this.swap(intArray,j-1,j);
                    }
                }
                unSorted--;
            }

        }
        return intArray;
    }
    swap(intArray,i,j){
        const temp =intArray[i];
        intArray[i]=intArray[j];
        intArray[j]=temp;
    }
}

const bubble = new bubbleSort();
const result= bubble.sort([-22, -15, 1, 7, 20, 35, 55]);
console.log(result);
package BubbleSort;

public class BubbleSort {
	
	int[] sort(int[]a) {
		if(a==null) throw new IllegalArgumentException("you have to pass Array of Integer");
		int unSortedCount=a.length;
		int size=unSortedCount;
		if(size<1) return a;
		for(int i=0;i<size;i++) {
			for(int j=1;j<unSortedCount;j++) {
				if(a[j-1] >a[j]) {
					int temp=a[j-1];
					a[j-1]=a[j];
					a[j]=temp;
				}
			}
			unSortedCount--;
		}
		return a;
	}

}

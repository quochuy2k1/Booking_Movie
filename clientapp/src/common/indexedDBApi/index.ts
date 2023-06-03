export class IndexedDBService {
  private dbName: string;
  private dbVersion: number;
  private objectStoreName: string;

  constructor(dbName: string, dbVersion: number, objectStoreName: string) {
    this.dbName = dbName;
    this.dbVersion = dbVersion;
    this.objectStoreName = objectStoreName;
  }

  public openDB(): Promise<IDBDatabase> {
    return new Promise((resolve, reject) => {
      const request = window.indexedDB.open(this.dbName, this.dbVersion);
      const objectStoreName = this.objectStoreName; // Lưu trữ objectStoreName trong biến khác

      request.onerror = function (event) {
        reject('Error opening database');
      };

      request.onupgradeneeded = function (event) {
        const db = (event.target as IDBOpenDBRequest).result;
        if (!db.objectStoreNames.contains(objectStoreName)) { // Sử dụng biến objectStoreName
          db.createObjectStore(objectStoreName, { keyPath: 'userName' })
        }
      };

      request.onsuccess = function (event) {
        const db = (event.target as IDBOpenDBRequest).result;
        resolve(db);
      };
    });
  }


  public addData(db: IDBDatabase, data: any): Promise<void> {
    return new Promise((resolve, reject) => {
      const transaction = db.transaction([this.objectStoreName], 'readwrite');
      const objectStore = transaction.objectStore(this.objectStoreName);

      const request = objectStore.add(data);

      request.onsuccess = function (event) {
        resolve();
      };

      request.onerror = function (event) {
        reject('Error adding data');
      };
    });
  }

  public getData(db: IDBDatabase, userName: string): Promise<any> {
    return new Promise((resolve, reject) => {
      const transaction = db.transaction([this.objectStoreName], 'readonly');
      const objectStore = transaction.objectStore(this.objectStoreName);
      const request = objectStore.get(userName);

      request.onsuccess = (event) => {
        const result = (event.target as IDBRequest).result;
        resolve(result);
      };

      request.onerror = (event) => {
        reject((event.target as IDBRequest).error);
      };
    });
  }

  public editData(db: IDBDatabase, data: any): Promise<void> {
    return new Promise((resolve, reject) => {
      const transaction = db.transaction([this.objectStoreName], 'readwrite');
      const objectStore = transaction.objectStore(this.objectStoreName);

      // Tìm bản ghi cần chỉnh sửa dựa trên trường "code"
      const request = objectStore.get(data.code);

      request.onsuccess = (event) => {
        const existingData = (event.target as IDBRequest).result;

        if (existingData) {
          // Cập nhật dữ liệu của bản ghi
          // Merge the updated data into the existing record
          const updatedData = Object.assign({}, existingData, data);

          // Use the put method to update the record
          const updateRequest = objectStore.put(updatedData);

          updateRequest.onsuccess = () => {
            resolve();
          };

          updateRequest.onerror = (event) => {
            reject((event.target as IDBRequest).error);
          };
        } else {
          reject(new Error('Record not found.'));
        }
      };

      request.onerror = (event) => {
        reject((event.target as IDBRequest).error);
      };
    });
  }

  public deleteData(db: IDBDatabase, code: string): Promise<void> {
    return new Promise((resolve, reject) => {
      const transaction = db.transaction([this.objectStoreName], 'readwrite');
      const objectStore = transaction.objectStore(this.objectStoreName);

      const request = objectStore.delete(code);

      request.onsuccess = () => {
        resolve();
      };

      request.onerror = (event) => {
        reject((event.target as IDBRequest));
      };
    });
  }
  public countData(db: IDBDatabase): Promise<void> {
    return new Promise((resolve, reject) => {
      const transaction = db.transaction([this.objectStoreName], 'readonly');
      const objectStore = transaction.objectStore(this.objectStoreName);

      const request = objectStore.count();

      request.onsuccess = () => {
        resolve();
      };

      request.onerror = (event) => {
        reject((event.target as IDBRequest));
      };
    });
  }



}

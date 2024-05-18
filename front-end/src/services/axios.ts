import axios, { AxiosResponse, ResponseType } from 'axios';

// Server path
const serverPath = import.meta.env.VITE_API_BASE_URL as string;

export type THttpMethod = 'get' | 'put' | 'post' | 'delete';

const DEFAULT_TIMEOUT = 60;

export type ApiResponse<T> = {
  data: T;
  status: number;
  [x: string]: unknown;
};

export async function api<T = never>(
  method: THttpMethod,
  url: string,
  data?: never,
  params?: never,
  responseType: ResponseType = 'json',
  timeoutInSeconds: number = DEFAULT_TIMEOUT
): Promise<ApiResponse<T>> {
  const user = JSON.parse(localStorage.getItem('user') as string);
  const token = user ? user?.tokens?.accessToken : '';
  const axiosInstance = axios.create({
    baseURL: serverPath,
    timeout: timeoutInSeconds * 1000,
    headers: {
      Accept: 'application/json',
      'Content-Type': 'application/json',
      Authorization: `Bearer ${token}`,
    },
    responseType,
  });

  const requestOptions: { method: "get" | "put" | "post" | "delete"; data: never | undefined; params: never | undefined; url: string } = {
    method,
    url,
    data,
    params,
  };
  console.log(requestOptions)
  const response: AxiosResponse<T> = await axiosInstance.request(requestOptions);

  const apiResponse: ApiResponse<T> = {
    data: response.data,
    status: response.status,
  };

  return apiResponse;

}

export async function fetchBinary(
  method: THttpMethod,
  url: string,
  data?: never | undefined,
  params?: never,
  timeoutInSeconds: number = DEFAULT_TIMEOUT
): Promise<ArrayBuffer> {
  const user = JSON.parse(localStorage.getItem('user') as string);
  const token = user ? user?.tokens.accessToken : '';

  const axiosInstance = axios.create({
    baseURL: serverPath,
    timeout: timeoutInSeconds * 1000,
    headers: {
      Accept: 'application/pdf',
      Authorization: `Bearer ${token}`,
    },
    responseType: 'arraybuffer',
  });

  try {
    const requestOptions: { method: "get" | "put" | "post" | "delete"; data: never | undefined; params: never | undefined; url: string } = {
      method,
      url,
      data,
      params,
    };

    const response: AxiosResponse<ArrayBuffer> = await axiosInstance.request(requestOptions);

    return response.data;
  } catch (error) {
    console.error(`Error from ${method.toUpperCase()}: `, error);
    throw error;
  }
}
